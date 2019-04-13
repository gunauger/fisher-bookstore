import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BooksComponent } from './books/books/books.component';
import { BookRowComponent } from './books/book-row/book-row.component';
import { BookDetailComponent } from './books/book-detail/book-detail.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AuthorsComponent } from './authors/authors/authors.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BooksComponent,
    BookRowComponent,
    BookDetailComponent,
    NavbarComponent,
    AuthorsComponent
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
