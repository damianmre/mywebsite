import { Component, Inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Woord } from '../../models/woord';
import { WoordenschatService } from '../../services/woordenschat.services';
import { MatListModule } from '@angular/material/list';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  selector: 'woordenlijst',
  standalone: true,
  imports: [CommonModule, MatListModule, MatExpansionModule],
  templateUrl: './woordenlijst.component.html',
  styleUrl: './woordenlijst.component.css',
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
