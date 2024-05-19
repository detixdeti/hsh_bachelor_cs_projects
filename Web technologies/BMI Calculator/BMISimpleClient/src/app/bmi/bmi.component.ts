import { Component, OnInit } from '@angular/core';
import { BmiCalcService } from '../bmi-calc.service';

@Component({
  selector: 'app-bmi',
  templateUrl: './bmi.component.html',
  styleUrls: ['./bmi.component.css']
})
export class BmiComponent  {

  public gewicht: number;
  public groesse: number;         
                                
  public bmi!: number;          // mit dem ! muss die Varaible nicht 
                                // im Konstruktor initialisert werden
  public answer!: string;
  public errorGewicht!: string;
  public errorGroesse!: string;

  constructor(private bmiService: BmiCalcService) {
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

  clickButton() {
    this.bmi = this.bmiService.calculateBMI(this.gewicht, this.groesse);
    this.answer =  this.bmiService.getAnswer(this.gewicht, this.groesse);
  }
}
