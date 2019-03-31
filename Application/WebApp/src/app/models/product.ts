import { Entity } from './Entity';

export interface Product extends Entity {
  productType: string;
  user: number;
  status: string;
  check: [string, [boolean]];
  stock: number;
  publicId: string;
  name: string;
  description: string;
  dimensions: string;
  dimensionsPackage: string;
  weight: string;
  weightPackage: string;
  colour: string;
  material: string;
  code: string;
  category: string;
  keywords: [string];
}
