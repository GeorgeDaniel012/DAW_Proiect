import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { ProduseComponent } from './produse/produse.component';

export const routes: Routes = [
    // {
    //     path: "",
    //     component: Pag1Component
    // },
    {
        path: "produse",
        component: ProduseComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];