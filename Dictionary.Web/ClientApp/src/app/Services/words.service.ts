import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EnglishWord } from '../Models/english-word';
import { UkrainWord } from '../Models/ukrain-word';

@Injectable({
  providedIn: 'root'
})
export class WordsService {
  ukrwords: UkrainWord[];
  apiUrl: string = 'https://localhost:5001';
  constructor(private http: HttpClient) { }

  getUkrWords(englword: string): Observable<UkrainWord[]> {
    console.log("from service :"+ englword);
    return this.http.get<UkrainWord[]>(`${this.apiUrl}/words/ukr?word=${englword}`);
  }
}
