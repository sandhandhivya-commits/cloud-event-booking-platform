import { Routes } from '@angular/router';
import { EventListComponent } from './features/events/pages/event-list/event-list.component';
import { EventCreateComponent } from './features/events/pages/event-create/event-create.component';

export const routes: Routes = [
    {
    path: '',
    component: EventListComponent
  },
  {
    path: 'create',
    component: EventCreateComponent
  }
];
