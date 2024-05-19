import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BmiCalcService {

  calculateBMI(weight: number , height: number ): number{
    return weight / (height * height);
  }
  getAnswer(weight: number , height: number ): string{
    let bmi = this.calculateBMI(weight, height);
    let answer = "du hast Normalgewicht";
    if (bmi < 20){
      answer = " du hast Untergewicht";
    }
    if (bmi > 25){
      answer = " du hast Übergewicht";
    }
    return answer;
  }

}
