import './styles.css';

import { useState, useEffect, useCallback } from 'react';
import { loadPosts } from '../../utils/load-posts';
import { Posts } from '../../components/Posts';
import { Botao } from '../../components/Botao';
import { CaixaDeTexto } from '../../components/CaixaDeTexto';


export const Home = () => {

  const [posts, setPosts] = useState([]);
  const [currentPage, setCurrentPage] = useState(0);
  const [postsPerPage] = useState(6);
  const [allPosts, setAllPosts] = useState([]);
  const [searchValue, setSearchValue] = useState("");

  const noMorePosts = currentPage + postsPerPage >= allPosts.length;

  const filteredPosts = !!searchValue ? allPosts.filter(post => {
    return post.title.toLowerCase().includes(searchValue.toLocaleLowerCase())
  }) : posts;

  const handleLoadPosts = useCallback(async (currentPage, postsPerPage) => {
    const postsAndPhostos = await loadPosts();

    setPosts(postsAndPhostos.slice(currentPage,postsPerPage))
    setAllPosts(postsAndPhostos)
  }, [])

  useEffect(() => {
    handleLoadPosts(0, postsPerPage);
  }, [handleLoadPosts, postsPerPage]);

  const loadMorePosts = () => {
    const nextPage = currentPage + postsPerPage;
    const nextPosts = allPosts.slice(nextPage, nextPage + postsPerPage);
    posts.push(...nextPosts);

    setPosts(posts);
    setCurrentPage(nextPage);
  }

  const handleChange = (e) => {
    const {value} = e.target;
    setSearchValue(value);
  }

  return (
    <section className='container'>
      <div className='search-container'> 
        <CaixaDeTexto onChange={handleChange} value={searchValue}></CaixaDeTexto>
      </div>

      {filteredPosts.length > 0 &&
      (
        <Posts posts={filteredPosts}></Posts>
      )}
        
      {filteredPosts.length === 0 && (
        <div>
          <h3>Pesquisa não retornou valor</h3>
          <Posts posts={posts}></Posts>
        </div>
      )}
      
      {!searchValue && (
        <div className='button-container'>
        <Botao text="Carregar mais posts" onClick={loadMorePosts} disabled={noMorePosts}></Botao>
      </div>
      )}
      
    </section>
  );
}

export default Home;
