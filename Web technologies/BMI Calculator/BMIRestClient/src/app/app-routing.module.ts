import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AusgabeComponent } from './ausgabe/ausgabe.component';
import { EingabeComponent } from './eingabe/eingabe.component';


const routes: Routes = [
  {path: 'eingabe', component: EingabeComponent },
  {path: 'ausgabe', component: AusgabeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

