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
    	Tags { "Queue"="Transparent" "RenderType"="Opaque" }
    
        CGPROGRAM
        #pragma surface surf Lambert exclude_path:prepass noforwardadd
		//#pragma target 3.0

        sampler2D _MainTex;
        half4 _FlashColor;
        half _Width;
        half _LoopTime;
        half _Interval;
            
        struct Input 
		{
			half2 uv_MainTex;
		};
           
        half inFlash(half2 uv)
        {	            
            half cot = 0.3;//光条角度
           
			half xBottomRightBound = (_Time.y - (int)_Time.y) * (1.0 + cot);
            half xBottomLeftBound = xBottomRightBound - _Width;
            
            half xProj = uv.x + uv.y * cot;

            return xProj > xBottomLeftBound && xProj < xBottomRightBound ? 1.0 - abs(2.0 * xProj - (xBottomLeftBound + xBottomRightBound)) / _Width : 0;
        }
        
        void surf (Input IN, inout SurfaceOutput o)
        {                
            half4 texCol = tex2D(_MainTex, IN.uv_MainTex);
			half brightness = inFlash(IN.uv_MainTex);
            o.Albedo = texCol.rgb + _FlashColor.rgb * brightness;
            o.Alpha = texCol.a;
        }
        
        ENDCG
    }
    
    FallBack "Unlit/Transparent"
}