import { Component, OnInit } from '@angular/core';
import { Person } from '../person';
import { Router } from '@angular/router';
import { ExchangeService } from '../exchange.service';

@Component({
  selector: 'app-eingabe',
  templateUrl: './eingabe.component.html',
  styleUrls: ['./eingabe.component.css']
})
export class EingabeComponent  {
  public gewicht: number;
  public groesse: number;
  public errorGewicht!: string;
  public errorGroesse!: string;

  constructor(private router: Router, private exchange : ExchangeService) {
    this.gewicht = 75;
    this.groesse = 1.80;
  }

  checkGewicht(gewicht: number): void {
    if (isNaN(gewicht) || gewicht < 40 || gewicht > 150) {
      this.errorGewicht = 'Gewicht nicht gültig';
    }
    else { this.errorGewicht = ''; }
  }
  checkGroesse(groesse: number): void {
    if (groesse < 1.50 || groesse > 2.10) {
      this.errorGroesse = 'Größe nicht gültig';
    }
    else { this.errorGroesse = ''; }
  }
  clickButton(): void {
    let p = new Person(this.gewicht, this.groesse, 0, "");
    this.exchange.saveData(p);
    this.router.navigate(['/ausgabe']);
  }

}
