import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { ProduseComponent } from './produse/produse.component';
import { UtilizatoriComponent } from './utilizatori/utilizatori.component';

export const routes: Routes = [
    {
        path: "users",
        component: UtilizatoriComponent
    },
    {
        path: "produse",
        component: ProduseComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];