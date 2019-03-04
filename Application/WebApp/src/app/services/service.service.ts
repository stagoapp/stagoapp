import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Entity } from '../models/Entity';
import { Serializer } from '../models/serializer';

@Injectable({
  providedIn: 'root'
})
export class ServiceService<T extends Entity> {

  private url: string;
  private serializer: Serializer;

  constructor(private httpClient: HttpClient,
              private endpoint: string) { }

  public getById(id: number): Observable<T> {
    return this.httpClient
      .get(`${this.url}/${this.endpoint}/${id}`)
      .pipe(map((data: any) => this.serializer.fromJson(data) as T));
  }

  public getByFilter(filter: string): Observable<T> {
    return this.httpClient
      .get(`${this.url}/${this.endpoint}/${filter}`)
      .pipe(map((data: any) => this.serializer.fromJson(data) as T));
  }

  public getAll(queryOptions: string): Observable<T[]> {
    return this.httpClient
      .get(`${this.url}/${this.endpoint}?${queryOptions.toString()}`)
      .pipe(map((data: any) => this.convertData(data.items)));
  }

  public create(item: T): Observable<T> {
    return this.httpClient
      .post<T>(`${this.url}/${this.endpoint}`, this.serializer.toJson(item))
      .pipe(map(data => this.serializer.fromJson(data) as T));
  }

  public createAll(items: T[]): Observable<T[]> {
    return this.httpClient
      .post<T[]>(`${this.url}/${this.endpoint}`, this.serializer.fromJsonToList(items))
      .pipe(map(data => this.serializer.listToJson(data) as T[]));
  }

  public update(item: T): Observable<T> {
    return this.httpClient
      .put<T>(`${this.url}/${this.endpoint}/${item.id}`,
        this.serializer.toJson(item)).pipe(map(data => this.serializer.fromJson(data) as T));
  }

  public updateAll(items: T[]): Observable<T[]> {
    return this.httpClient
      .put<T[]>(`${this.url}/${this.endpoint}/${items}`,
        this.serializer.fromJsonToList(items)).pipe(map(data => this.serializer.listToJson(data) as T[]));
  }

  public delete(entity: T) {
    return this.httpClient
      .delete(`${this.url}/${this.endpoint}/${entity}`);
  }

  public deleteById(id: number) {
    return this.httpClient
      .delete(`${this.url}/${this.endpoint}/${id}`);
  }

  public deleteAll(entities: T[]) {
    return this.httpClient
      .delete(`${this.url}/${this.endpoint}/${entities}`);
  }

  private convertData(data: any): T[] {
    return data.map(item => this.serializer.fromJson(item));
  }
}
