import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.css']
})
export class LanguageComponent implements OnInit {
  languages: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getLanguages();
  }
  getLanguages() {
    this.http.get('http://localhost:5000/lg/languages').subscribe(d => this.languages = d, err => console.log(err));
  }


}
