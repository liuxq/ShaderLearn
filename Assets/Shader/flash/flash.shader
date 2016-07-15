Shader "Custom/flash" {
	Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _FlashColor ("Flash Color", Color) = (1,1,1,1)
        _Width ("Flash Width", Range(0, 1)) = 0.2
        _LoopTime ("Loop Time", Float) = 1
        _Interval ("Time Interval", Float) = 3
    }
    SubShader
    {
    	Tags { "Queue"="Transparent" "RenderType"="Transparent" }
    
        CGPROGRAM
        #pragma surface surf Lambert exclude_path:prepass noforwardadd
//		#pragma target 3.0

        sampler2D _MainTex;
        float4 _FlashColor;
        float _Angle;
        float _Width;
        float _LoopTime;
        float _Interval;
            
        struct Input 
	{
		half2 uv_MainTex;
	};
           
        float inFlash(half2 uv)
        {	
            float brightness = 0;
            
            float cot = 0.7;//光条角度
            
			float currentTime = _Time.y;
			float totalTime = _Interval + _LoopTime;
            float currentTurnStartTime = (int)((currentTime / totalTime)) * totalTime;
            float currentTurnTimePassed = currentTime - currentTurnStartTime - _Interval;
            
			float xBottomFarLeft = 0.0;
			float xBottomFarRight = 1.0 + cot;
			
			float percent = currentTurnTimePassed / _LoopTime;
            float xBottomRightBound = xBottomFarLeft + percent * (xBottomFarRight - xBottomFarLeft);
            float xBottomLeftBound = xBottomRightBound - _Width;
            
            float xProj = uv.x + uv.y * cot;
            
            if(xProj > xBottomLeftBound && xProj < xBottomRightBound)
            {
              	brightness = 1.0 - abs(2.0 * xProj - (xBottomLeftBound + xBottomRightBound)) / _Width;
            }

            return brightness;
        }
        
        void surf (Input IN, inout SurfaceOutput o)
        {                
            half4 texCol = tex2D(_MainTex, IN.uv_MainTex);
            float brightness = inFlash(IN.uv_MainTex);
        
            o.Albedo = texCol.rgb + _FlashColor.rgb * brightness;
            o.Alpha = texCol.a;
        }
        
        ENDCG     
    }
    
    FallBack "Unlit/Transparent"
}