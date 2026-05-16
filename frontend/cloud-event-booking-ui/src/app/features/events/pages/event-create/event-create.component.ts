import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { EventService } from '../../services/event.service';
import { Event } from '../../models/event.model';

@Component({
  selector: 'app-event-create',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './event-create.component.html'
})
export class EventCreateComponent {

  event:Event = {
    name: 'Dhivya',
    description: '',
    location: 'Chennai',
    date: ''
  };

  constructor(private eventService: EventService) {}

  createEvent() {
    this.eventService.createEvent(this.event).subscribe({
      next: () => {
        alert("Event Created Successfully");
      },
      error: (err) => {
        console.error(err);
      }
    });

  }

}