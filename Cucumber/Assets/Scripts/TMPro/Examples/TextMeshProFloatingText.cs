using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro.Examples
{
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisplayTextMeshFloatingText_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshProFloatingText _003C_003E4__this;

			private float _003CCountDuration_003E5__2;

			private float _003Cstarting_Count_003E5__3;

			private float _003Ccurrent_Count_003E5__4;

			private Vector3 _003Cstart_pos_003E5__5;

			private Color32 _003Cstart_color_003E5__6;

			private float _003Calpha_003E5__7;

			private float _003CfadeDuration_003E5__8;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDisplayTextMeshFloatingText_003Ed__16(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDisplayTextMeshProFloatingText_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshProFloatingText _003C_003E4__this;

			private float _003CCountDuration_003E5__2;

			private float _003Cstarting_Count_003E5__3;

			private float _003Ccurrent_Count_003E5__4;

			private Vector3 _003Cstart_pos_003E5__5;

			private Color32 _003Cstart_color_003E5__6;

			private float _003Calpha_003E5__7;

			private float _003CfadeDuration_003E5__8;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDisplayTextMeshProFloatingText_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public Font TheFont;

		private GameObject m_floatingText;

		private TextMeshPro m_textMeshPro;

		private TextMesh m_textMesh;

		private Transform m_transform;

		private Transform m_floatingText_Transform;

		private Transform m_cameraTransform;

		private Vector3 lastPOS;

		private Quaternion lastRotation;

		public int SpawnType;

		public bool IsTextObjectScaleStatic;

		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		private static WaitForSeconds[] k_WaitForSecondsRandom;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CDisplayTextMeshProFloatingText_003Ed__15))]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDisplayTextMeshFloatingText_003Ed__16))]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}
	}
}
