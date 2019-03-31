import { Entity } from './Entity';

export interface Review extends Entity {
  status: string;
  user: number;
  userReceiving: number;
  object: number;
  entityType: string;
  order: number;
  orderPackage: number;
  rating: number;
  title: string;
  content: string;
  isComplaint: boolean;
  isResolved: boolean;
}
