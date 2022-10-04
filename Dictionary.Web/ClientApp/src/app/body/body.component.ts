import { Component, OnInit } from '@angular/core';
import { UkrainWord } from '../Models/ukrain-word';
import { EnglishWord } from '../Models/english-word';
import { WordsService } from '../Services/words.service';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent implements OnInit {
  word: UkrainWord[] = [ ];
     

  inpword: string = '';
  constructor(private wordService: WordsService) { }

  ngOnInit() {
    
  }
  getUkrWords() {
    
    console.log(this.inpword);
    return this.wordService.getUkrWords(this.inpword)
      .subscribe((w: UkrainWord[]) => {
        this.word = w;
      console.log(this.word)},
      
        (e: any) => {
          console.log(e);
        }
      );
  }
}
