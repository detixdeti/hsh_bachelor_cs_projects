import { Component, OnInit } from '@angular/core';
import { Person } from '../person';
import { BmiCalcService } from '../bmi-calc.service';
import { ExchangeService } from '../exchange.service';

@Component({
  selector: 'app-ausgabe',
  templateUrl: './ausgabe.component.html',
  styleUrls: ['./ausgabe.component.css']
})
export class AusgabeComponent implements OnInit{
  public bmi!: number;          
  public answer!: string;

  constructor(private bmiService: BmiCalcService, private exchange: ExchangeService) {
  }
  ngOnInit(): void {
    this.exchange.subscriber$.subscribe(
      (person: Person) => {
      this.calculateBmiPerREST(person.weight, person.height);
    })
  }
  calculateBmiPerREST(weight: number, height: number): void {
    this.bmiService.callBmiRest(weight, height)
      .subscribe(
        (person: Person) => {
          this.bmi = person.bmi;
          this.answer = person.answer;
        },
        error => {this.answer = " !!!!!!  Error  !!!!!!";}
      );
  }
}
