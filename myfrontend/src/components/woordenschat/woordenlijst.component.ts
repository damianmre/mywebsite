import { Component, Inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Woord } from '../../models/woord';
import { WoordenschatService } from '../../services/woordenschat.services';

@Component({
  selector: 'woordenlijst',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './woordenlijst.component.html',
})
export class WoordenlijstComponent implements OnInit {
  woorden: Woord[] = [];

  constructor(@Inject(WoordenschatService) private WoordenschatService: WoordenschatService) {}

  ngOnInit(): void {
    this.WoordenschatService.getWoorden().subscribe(result => {
      this.woorden = result;
    });
  }
}
