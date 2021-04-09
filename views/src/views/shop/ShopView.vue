<template>
    <div class="show-view">
        <left-shop />
        <right-shop />
    </div>
</template>
<script>
import LeftShop from '../../components/shop/LeftShop.vue'
import RightShop from '../../components/shop/RightShop.vue'
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