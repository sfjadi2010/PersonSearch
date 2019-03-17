import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { PeopleComponent } from './people/people.component';
import { PersonDetailComponent } from './person-detail/person-detail.component';
import { AddPersonComponent } from './add-person/add-person.component';
import { PersonListComponent } from './person-list/person-list.component';

@NgModule({
  declarations: [
    PeopleComponent,
    PersonListComponent,
    PersonDetailComponent,
    AddPersonComponent
  ],
  imports: [CommonModule],
  exports: [PeopleComponent, AddPersonComponent, RouterModule]
})
export class PeopleModule {}
