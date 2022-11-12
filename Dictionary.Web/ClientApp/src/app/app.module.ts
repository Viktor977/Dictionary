import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { BodyComponent } from './body/body.component';
import { LoginComponent } from './auth/login/login.component';
import { SigninComponent } from './auth/signin/signin.component';
import { WordsService } from './Services/words.service';
import { UkrpageComponent } from './ukrpage/ukrpage.component';
import { EngpageComponent } from './engpage/engpage.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    BodyComponent,
    LoginComponent,
    SigninComponent,
    UkrpageComponent,
    EngpageComponent  
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path:'',redirectTo: '/header', pathMatch: 'full'},
      {path:'header',component:HeaderComponent},
      {path:'login',component:LoginComponent},
      {path:'signin',component:SigninComponent},
      {path:'ukr',component:UkrpageComponent},
      {path:'eng',component:EngpageComponent}
    ])
  ],
  providers: [WordsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
