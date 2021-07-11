import { Component, OnDestroy, OnInit } from '@angular/core';
import { StopReason } from 'src/app/_model/stop-reason.model';
import { StopReasonService } from 'src/app/_service/stop-reason.service';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-stop-reason',
  templateUrl: './stop-reason.component.html',
  styleUrls: ['./stop-reason.component.css']
})
export class StopReasonComponent implements OnInit {

  keys:string[]=[];
  stopReason:StopReason[]=[];

  constructor(private stopReasonService:StopReasonService) { }


  ngOnInit(): void {
    this.loadData();
  }

  loadData():any{
    this.stopReasonService.getTableData()
    .subscribe(data=>{
      this.keys=Object.keys(data[0].resultKeyValues);
      data[data.length-1].workOrderNumber="Toplam";
      this.stopReason=data;
    });
  };
}

