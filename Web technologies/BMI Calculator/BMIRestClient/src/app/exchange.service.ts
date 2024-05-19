import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Person } from './person';

@Injectable({
  providedIn: 'root'
})
export class ExchangeService {
  observer = new BehaviorSubject<Person>( new Person(0, 0, 0, "") );

  public subscriber$ = this.observer.asObservable();

  saveData(person : Person) {
    this.observer.next(person);
  }
}
