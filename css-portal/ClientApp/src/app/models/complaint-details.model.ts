import { Address } from './address.model';

export class ComplaintDetails {
    name: string;
    address: Address;
    propertyType: string;
    otherPropertyType: string;
    description: string;
    problems: string;
    occupantName: string;
    ownerName: string;
}
