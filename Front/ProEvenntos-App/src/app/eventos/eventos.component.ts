import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {
    public eventos: any = [];
    showImage = true;
    constructor(private http: HttpClient){}

    ngOnInit(): void{
      this.getEventos();
    }

    alterImage(){
      this.showImage = !this.showImage;
    }

    public getEventos():void{
      this.http.get('https://localhost:5001/api/eventos').subscribe(
        response => this.eventos = response,
        error => console.log(error)
      );
    }
}
