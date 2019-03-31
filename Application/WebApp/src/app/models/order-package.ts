import { Entity } from './Entity';
import { Order } from './order';

export interface OrderPackage extends Entity {
  user: number;
  status: string;
  timeline: [string, [Date]];
  price: [string, [number]];
  orders: [string, [Order]];
  publicId: string;
  description: string;
  notes: string;
  isFavourite: string;
  isCompleted: string;
}
