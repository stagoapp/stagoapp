import { Entity } from './Entity';

export interface Service extends Entity {
  user: number;
  serviceType: string;
  status: string;
  check: [boolean];
  publicId: string;
  name: string;
  description: string;
  code: string;
  category: string;
  keywords: [string];
}
