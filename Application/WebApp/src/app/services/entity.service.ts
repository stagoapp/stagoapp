import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Entity } from '../models/Entity';
import { HttpRequestService } from './http-request.service';

@Injectable({
  providedIn: 'root'
})
export class EntityService extends HttpRequestService<Entity> {

  constructor(httpClient: HttpClient) {
    super(httpClient, 'entity');
  }

}

