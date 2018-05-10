﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using System;

namespace com.mob.mobpush{
	public class CustomNotifyStyle {

		public static int TYPE_NORMAL = 0;
		public static int TYPE_BIG_TEXT = 1;
		public static int TYPE_BIG_PICTURE = 2;
		public static int TYPE_INBOX = 3;

		public Hashtable styleParams = new Hashtable();

		public void setContent(string content){
			styleParams ["content"] = content;
		}

		public void setTitle(string title){
			styleParams ["title"] = title;
		}

		public void setTickerText(string tickerText){
			styleParams ["tickerText"] = tickerText;
		}

		public void setStyle(int style){
			styleParams ["style"] = style;
		}

		public void setStyleContent(string styleContent){
			styleParams["styleContent"] = styleContent;
		}

		public void setInboxStyleContent(string[] inboxStyleContent){
			styleParams["inboxStyleContent"] = String.Join(",", inboxStyleContent);
		}
			
		/*显示通知的时间*/
		public void setTimestamp(long timeStamp){
			styleParams["timeStamp"] = timeStamp;
		}
			
		public void setVoice(bool isVoice){
			styleParams["isVoice"] = isVoice;
		}

		public void setShark(bool isShark){
			styleParams["isShark"] = isShark;
		}

		public void setLinght(bool isLight){
			styleParams["isLight"] = isLight;
		}

		public String getStyleParamsStr() {
			String jsonStr = MiniJSON.jsonEncode (styleParams);
			Debug.Log("StyleParams  ===>>> " + jsonStr );
			return jsonStr;
		}
	}
}
