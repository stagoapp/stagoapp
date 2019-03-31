import { Entity } from './Entity';

export interface Photo  extends Entity {
  status: string;
  object: string;
  entityType: string;
  index: number;
  url: string;
  urlPublic: string;
  description: string;
  isMain: boolean;
}
