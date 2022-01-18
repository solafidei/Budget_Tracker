import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { map, Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  public forecasts?: WeatherForecast[];
  //public transactions: Transaction[] = [];

  constructor(private http: HttpClient) {
    //http.get<WeatherForecast[]>('/api/weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));
  }

  title = 'Budget-Tracker-Web';

  ngOnInit() {
    // this.getTransactionList().subscribe(result => {
    //   this.transactions = result;
    //   console.log(this.transactions);

    // }, (error) => {
    //   console.log(error);
    // });
  }
  //getTransactionList(): Observable<Transaction[]> {
  //  return this.http.get<Transaction[]>('/api/transaction');
  //}
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
