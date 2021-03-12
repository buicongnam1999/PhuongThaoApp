<template>
    <div class="show-view">
        <left-shop />
        <right-shop />
    </div>
</template>
<script>
import LeftShop from '../components/shop-view/LeftShop.vue'
import RightShop from '../components/shop-view/RightShop.vue'
export default {
  components: { 
      LeftShop,
      RightShop 
      },
}
</script>
<style scoped>
.show-view{
    width: 93%;
    margin: 50px auto;
    display: flex;
    justify-content: space-between;
}
</style>