import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StopReason } from '../_model/stop-reason.model';

@Injectable({
  providedIn: 'root'
})
export class StopReasonService {

  constructor(private http: HttpClient) { }

  getTableData():Observable<StopReason[]>{
    return this.http.get<StopReason[]>('https://localhost:44384/api/home');
  }
}
