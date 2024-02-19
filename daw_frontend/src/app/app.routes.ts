import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { ProduseComponent } from './produse/produse.component';
import { UtilizatoriComponent } from './utilizatori/utilizatori.component';
import { ClientiComponent } from './clienti/clienti.component';
import { ComenziComponent } from './comenzi/comenzi.component';
import { AcasaComponent } from './acasa/acasa.component';

export const routes: Routes = [
    {
        path: "",
        component: AcasaComponent
    },
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
    },
    {
        path: "clienti",
        component: ClientiComponent
    },
    {
        path: "comenzi",
        component: ComenziComponent
    },
    {
        path: "locatii",
        component: ComenziComponent
    },
    {
        path: "recenzii",
        component: ComenziComponent
    },
    {
        path: "retete",
        component: ComenziComponent
    }
];