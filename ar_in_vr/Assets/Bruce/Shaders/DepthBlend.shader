Shader "Hidden/DepthBlend"
{
    Properties
    {
        _MainTex ("Main Texture", 2D) = "white" {}
        _SecondCameraTexture ("Second Texture", 2D) = "white" {}
        _SecondCameraDepthTexture ( "Second camera depth", 2D) = "black" {}
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
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
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
            sampler2D _CameraDepthTexture;
            sampler2D _SecondCameraDepthTexture;
            sampler2D _SecondCameraTexture;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col;// = tex2D(_SecondCameraTexture, i.uv);
                 fixed4 col2;// = tex2D(_MainTex, i.uv);
//return col2;
                 fixed4 blend = (0.5 * col) + (0.5 * col2);

                float mainDepth = tex2D(_CameraDepthTexture, i.uv);
                float secondDepth = tex2D(_SecondCameraDepthTexture, i.uv);
                
                if(mainDepth > secondDepth)
                {
                    col = tex2D(_MainTex, i.uv);
                }
                else
                {
                    //col = fixed4(1, 0, 0, 1);
                    col = (.6 * tex2D(_SecondCameraTexture, i.uv)) + (0.4 * tex2D(_MainTex, i.uv));
                }

                return col;
                // //float depth = SAMPLE_DEPTH_TEXTURE(_SecondCameraTexture, i.uv);
                // // // just invert the colors
                // // col.rgb = 1 - col.rgb;
                //return blend;
                
                 //return fixed4(secondDepth, secondDepth, secondDepth, 1);
            }
            ENDCG
        }
    }
}
