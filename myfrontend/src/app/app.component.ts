import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WoordenlijstComponent } from "../components/woordenschat/woordenlijst.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, WoordenlijstComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'myfrontend';
}
