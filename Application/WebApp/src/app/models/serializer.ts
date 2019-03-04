import { Entity } from './Entity';

export interface Serializer {
  fromJson(json: any): Entity;
  toJson(resource: Entity): any;
  fromJsonToList(json: any): Entity[];
  listToJson(resource: Entity[]): any;
}
