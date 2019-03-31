import { Entity } from './Entity';
import { User } from './user';

export interface Account extends Entity {
  user: string;
  status: string;
  accountNumber: number;
  branchNumber: number;
  bankNumber: number;
}
