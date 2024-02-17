import { Produs } from "./produs";

export interface Comanda {
    id: Number,
    produse: Produs[],
    clientId: Number,
    dataComanda: Date
}