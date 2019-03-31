import { Entity } from './Entity';

export interface Price extends Entity {
  object: string;
  entityType: string;
  status: string;
  unitType: string;
  saleType: string;
  priceInitial: number;
  priceDelivery: number;
  priceInsurance: number;
  priceInstallation: number;
  priceTax: number;
  priceFees: number;
  priceTotal: number;
  priceDiscount: number;
  priceMinimum: number;
  priceMaximum: number;
  amountMinimum: number;
  amountMaximum: number;
  currency: string;
  description: string;
}
