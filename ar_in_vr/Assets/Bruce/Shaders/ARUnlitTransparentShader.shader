Shader "Unlit/ARShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        Alpha ("Alpha", float) = 1
        HorizontalEdge ("HorizontalEdge", float) = 0
        VerticalEdge ("VerticalEdge", float) = 0
        
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
        LOD 100


        Pass
        {
            ZWrite ON
            Ztest LEqual

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 screenPos : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float Alpha;
            float HorizontalEdge;
            float VerticalEdge;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.screenPos = ComputeScreenPos(o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 screenPosition = i.screenPos.xy/i.screenPos.w;

                if(screenPosition.x < HorizontalEdge || screenPosition.x > (1-HorizontalEdge) || screenPosition.y < VerticalEdge || screenPosition.y > (1-VerticalEdge))
                {
                    discard;
                }
                
                fixed4 col = tex2D(_MainTex, i.uv);
                col.a = Alpha;
                return col;
            }
            ENDCG
        }
    }
}
