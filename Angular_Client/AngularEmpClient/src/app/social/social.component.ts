import { Component } from '@angular/core';
import { FriendService } from '../friend.service';
import { Friend } from '../Friend';

@Component({
  selector: 'app-social',
  templateUrl: './social.component.html',
  styleUrls: ['./social.component.css']
})
export class SocialComponent {
/**
 *
 */
constructor(private _service :FriendService) {
  }

  friendlist:Friend[];
  ngOnInit()
  {
   this.friendlist=this._service.getFriends();
  this.friendlist.sort((a,b)=>a.likecount-b.likecount);
   this.friendlist.reverse()
  }
 IncrementCount(friend:Friend)
{
 let count= this._service.getLikeCount(friend)
   count=count+1;
   friend.likecount=count
}


}
