import { Entity } from './Entity';

export interface Discount extends Entity {
  user: number;
  status: string;
  object: string;
  entityType: number;
  amount: number;
  percentage: number;
  code: string;
  isActive: boolean;
  dateStart: Date;
  dateEnd: Date;
}
