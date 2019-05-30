import { Photo } from './photo';
import { Entity } from './Entity';
import { Contact } from './contact';

export interface User extends Entity {
    status: string;
    password : string;
    username : string;
    publicName: string;
    biography : string;
    gender : string;
    requesting : boolean;
    offering : boolean;
    points : number;
    rating : number;
    isActive : boolean;
    isCorp : boolean;
    isFeatured : boolean;
    isAdmin : boolean;
    dateOfBirth : Date;
    dateLastActive : Date;
    userFavourites :string[];
    userSocialMedia :string[];
    userTypes :string[];
    contact: Contact;
}
