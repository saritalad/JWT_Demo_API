import { Component } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Component({
  selector: 'app-student-marks',
  templateUrl: './student-marks.component.html',
  styleUrls: ['./student-marks.component.css']
})
export class StudentMarksComponent {
  private marksSubject = new BehaviorSubject<number[]>([]);
  sortedMarks$: Observable<number[]>;
  newMark: number | undefined;
  constructor() {
    // Create an observable that emits the sorted marks whenever the marks array changes
    this.sortedMarks$ = this.marksSubject.pipe(map(marks)=>this.marksSubject.slice().sort((a.b)=>a-b))
    );
  }
  addMark() {
    if (this.newMark !== undefined) {
      const currentMarks = this.marksSubject.value;
      const newMarks = [...currentMarks, this.newMark];
      this.marksSubject.next(newMarks);
      this.newMark = undefined; // Clear the input after adding the mark
    }
  }



}
