import { Contact } from './contact';
import { Service } from './service';
import { Entity } from './Entity';
import { Discount } from './discount';

export interface Order extends Entity {
  object: string;
  entityType: string;
  services: [string, [Service]];
  orderPackage: number;
  user: number;
  userOffering: number;
  contacts: [string, [Contact]];
  prices: [string, [number]];
  discount: Discount;
  status: string;
  timeline: [string, [Date]];
  amount: number;
  publicId: string;
  code: string;
  description: string;
  notes: string;
  isRent: boolean;
  isConfirmed: boolean;
  isCompleted: boolean;
}
