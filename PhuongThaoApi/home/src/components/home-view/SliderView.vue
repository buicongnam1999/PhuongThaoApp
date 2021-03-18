<template>
   <div class="slider">
     <transition name="left">
     
     </transition>
        <div class="slider-view" v-for="(slider,index) in sliders" :key="index" v-show="visibleSlider === index">
            <img :src="require(`../../assets/img/banner/food/${sliders[index]}`)" alt="" srcset="" width="100%" height="670px">
        </div>
        <button class="next" @click="next">Next</button>
        <button class="prev" @click="prev">Prev</button>
   </div>
</template>

<script>
export default {
    data() {
      return {
        sliders:[
          '3-5.jpg',
          '3-2.jpg',
        ],
        visibleSlider:0,
      }
    },
    methods:{
      next: function(){
        if(this.visibleSlider >= this.sliderLen -1){
          this.visibleSlider = 0;
        }else{
          this.visibleSlider++;
        }
      },
      prev: function(){
        if(this.visibleSlider <= 0){
          this.visibleSlider = this.sliderLen - 1;
        }else{
          this.visibleSlider--;
        }
      }
    },
    computed: {
      sliderLen(){
        return this.sliders.length
      }
    },
}
</script>

<style scoped>
.slider{
    /* position: relative; */
    width: 100%;
    height: 670px;
    overflow: hidden;
}
.slider-view{
    animation: leftInAnimation 0.4s ease-in-out;
}
button{
  outline: none;
  border: none;
  height: 40px;
  width: 50px;
  position: absolute;
  top: calc(50%);
  cursor: pointer;
  background: rgba(0, 0, 0, 0.8);
  color: #fff;
}
button:active, button:hover{
  outline: none;
  border: none;
}
.next{
  margin-top: 200px;
  right: 0;
}
.prev{
  margin-top: 200px;
  left: 0;
}
</style>