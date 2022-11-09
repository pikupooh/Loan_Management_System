import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public profiles?: GetProfiles[];

  constructor(http: HttpClient) {
    http.get<GetProfiles[]>('https://localhost:7061/api/Profile/getAllProfiles').subscribe(result => {
      this.profiles = result;
      console.log(result);
    }, error => console.error(error));
  }

  title = 'LoanManagementSystem.Frontend';
}

interface GetProfiles {
  id: number;
  custname: string;
  email: string;
  pan: string,
  phoneno: string
}
