import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StopReasonComponent } from './page/stop-reason/stop-reason.component';

const routes: Routes = [
  { path: 'first-component', component: StopReasonComponent },
  { path: '**', component: StopReasonComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
