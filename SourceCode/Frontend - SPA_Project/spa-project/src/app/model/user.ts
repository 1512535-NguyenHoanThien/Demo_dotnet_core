export class RegisterUser {
    id: string;
    fullname: string;
    phoneNumber: string;
    email: string;
    role: string;
}

export class ViewUser {
    id: string;
    fullname: string;
    phoneNumber: string;
    email: string;
    role: string;
    dateOfBirth: Date;
    address: string;
    status: boolean;
    gender: string;
}
