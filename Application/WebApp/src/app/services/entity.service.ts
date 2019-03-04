import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ServiceService } from './service.service';
import { Entity } from '../models/Entity';

@Injectable({
  providedIn: 'root'
})
export class EntityService extends ServiceService<Entity> {

  constructor(httpClient: HttpClient) {
    super(httpClient, 'entity');
  }

}

