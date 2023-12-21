import { Injectable } from '@angular/core';
import { Friend } from './Friend';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FriendService {
  friends:Friend[]=[{name:"sophia",likecount:20},
  {name:"Elon",likecount:10},
  {name:"Merry",likecount:30},
  {name:"John",likecount:9},
  {name:"Mia",likecount:7}
  ]
  
  
  getFriends()
  {
  
    return this.friends
  }
  
getLikeCount(friend:Friend)
{

return friend.likecount;

}


}
