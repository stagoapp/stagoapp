import { Entity } from './Entity';

export interface Message extends Entity {
  status: string;
  user: string;
  userReceiving: string;
  title: string;
  content: string;
  isRead: string;
  dateSent: string;
  dateRead: string;
}
