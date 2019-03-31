import { Entity } from './Entity';

export interface Contact extends Entity {
  user: number;
  status: string;
  contactType: string;
  locationType: string;
  firstName: string;
  lastName: string;
  email: string;
  phoneAreaCode: number;
  extension: number;
  phone: string;
  phoneAdditional: string;
  address: string;
  unit: string;
  buzzer: string;
  postalCode: string;
  city: string;
  province: string;
  country: string;
  countryCode: string;
  notes: string;
  isMain: boolean;
  isFavourite: boolean;
}
