import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found.component';
import { AddPersonComponent } from './people/add-person/add-person.component';
import { PeopleModule } from './people/people.module';
import { PeopleComponent } from './people/people/people.component';

const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "people" },
  { path: "people", component: PeopleComponent },
  { path: "add", component: AddPersonComponent },
  { path: "**", component: PageNotFoundComponent }
];

@NgModule({
  imports: [PeopleModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
