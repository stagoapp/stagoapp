import { Entity } from './Entity';

export interface Photo  extends Entity {
    url: string;
    description: string;
    dateAdded: Date;
    isMain: boolean;
}
