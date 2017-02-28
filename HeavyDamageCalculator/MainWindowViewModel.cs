﻿using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyDamageCalculator {
	class MainWindowViewModel : BindableBase {
		// 最大耐久
		int maxHpValue = 35;
		public int MaxHpValue {
			get { return maxHpValue; }
			set {
				this.SetProperty(ref this.maxHpValue, value);
				// 現在耐久より小さければ、現在耐久の値を小さくする
				if(nowHpValue > value) {
					NowHpValue = value;
				}
			}
		}
		// 現在耐久
		int nowHpValue = 35;
		public int NowHpValue {
			get { return nowHpValue; }
			set {
				this.SetProperty(ref this.nowHpValue, Math.Min(maxHpValue, value));
				// 最大耐久より大きければ、最大耐久の値を大きくする
				if(maxHpValue < value) {
					MaxHpValue = value;
				}
			}
		}
	}
}