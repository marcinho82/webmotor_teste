import { Component, Input, OnInit } from '@angular/core';
import { ServicesMotor } from '../Services/ServicesMotor';
import { Router, ActivatedRoute} from '@angular/router';
import { Anuncio } from '../Models/Anuncio';

@Component({
  selector: 'app-home',
  templateUrl: './editar.component.html',
})
export class EditarComponent implements OnInit {

 
  id: any; 
  anuncio: any;
  _service: ServicesMotor;
  

 
  constructor(services: ServicesMotor, private route: Router) {
    this._service = services;
    this.id = this.route.getCurrentNavigation().extras.state.id;
  }

  salvar(anuncio) { 
    this._service.updateAnuncios(anuncio);
    this.route.navigate(['/']);
   }

  ngOnInit() {
    if (this.id != 0) {
      this._service.getAnuncioId(this.id).then(data => this.anuncio = data);
    }    
    
   
  }

}
