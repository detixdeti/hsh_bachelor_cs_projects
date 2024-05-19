import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'BMIAngularRESTClient';

  constructor(private router: Router) {   }

  public ngOnInit(){
    this.router.navigate(['/eingabe']);
  }
}
